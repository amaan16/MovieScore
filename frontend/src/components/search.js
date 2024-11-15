import React, { useState, useContext, useEffect } from 'react';
import { MovieContext } from '../movieContext';
import { Link } from 'react-router-dom';
import NavBar from './navBar';
import './search.css';

function Search() {
    const [searchTerm, setSearchTerm] = useState('');
    const [searchResult, setSearchResult] = useState([]);
    const { setSelectedMovie } = useContext(MovieContext);

    const handleSearch = async (e) => {
        e.preventDefault();

        const response = await fetch(`http://localhost:5057/search/${searchTerm}`);
        const data = await response.json();

        setSearchResult(data); // Update search result
    };

    // Use useEffect to log searchResult after it changes
    useEffect(() => {
        console.log("Updated searchResult:", searchResult);
    }, [searchResult]);

    return (
        <div className="search-page background-container">
            <NavBar />
            <form onSubmit={handleSearch} className="search-form">
                <div className="search-bar">
                    <input
                        type="text"
                        className="search-field"
                        value={searchTerm}
                        onChange={(e) => setSearchTerm(e.target.value)}
                        placeholder="Search movie or show..."
                    />
                    <button type="submit" className="search-button">Search</button>
                </div>
            </form>

            <div className="search-results">
                {searchResult.map((s) => (
                    <div className="result-item" key={s.id}>
                        <div className="movie-card">
                            {s.path && (
                                <div className="poster-container">
                                    <Link to={`/movie`} onClick={() => setSelectedMovie(s.id)}>
                                        <img
                                            src={'/images' + s.path}
                                            alt={s.title}
                                            className="poster-image"
                                        />
                                    </Link>
                                </div>
                            )}
                            <div className="movie-info">
                                <Link to={`/movie`} onClick={() => setSelectedMovie(s.id)}>
                                    <h4 className="movie-title">{s.title}</h4>
                                </Link>
                            </div>
                        </div>
                    </div>
                ))}
            </div>
        </div>
    );
}

export default Search;
