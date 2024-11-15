import React, { useContext, useState, useEffect } from 'react';
import { MovieContext } from '../movieContext';
import './movieDetail.css';
import NavBar from './navBar';
import RatingModal from './RatingModal';

function MovieDetail() {
    const { selectedMovie } = useContext(MovieContext);
    const [isModalOpen, setIsModalOpen] = useState(false);
    const [currentMovie, setCurrentMovie] = useState(null);
    const API_BASE_URL = "https://moviescorebackend-abbscmgzexfdfhg0.northcentralus-01.azurewebsites.net";


    useEffect(() => {
        const fetchMovieDetails = async () => {
            if (selectedMovie) {
                try {
                    const response = await fetch(API_BASE_URL+`/movies/${selectedMovie}`);
                    if (!response.ok) {
                        throw new Error('Failed to fetch movie details');
                    }
                    const movie = await response.json();
                    setCurrentMovie(movie);
                } catch (error) {
                    console.error('Error fetching movie details:', error);
                }
            }
        };

        fetchMovieDetails();
    }, [selectedMovie]);

    const handleOpenModal = () => setIsModalOpen(true);
    const handleCloseModal = () => setIsModalOpen(false);

    const handleRatingSubmit = async (rating) => {
        const movieId = selectedMovie;
        try {
            const response = await fetch(API_BASE_URL+`/movies/rate/${movieId}/${rating}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                }
            });

            if (!response.ok) {
                throw new Error('Failed to update rating');
            }

            const updatedMovie = await response.json();
            console.log(`Rated movie ${updatedMovie.title}: ${updatedMovie.rating}/10`);
            setCurrentMovie(updatedMovie);

        } catch (error) {
            console.error('Error updating rating:', error);
        }
    };

    const addToWatchlist = () => {
        // Add logic to handle adding the movie to the watchlist
    };

    // Check if selectedMovie exists and currentMovie has been fetched
    if (!selectedMovie || !currentMovie) return <p>Loading movie details...</p>;

    return (
        <div className='background-container'>
            <NavBar />

            <div className="movie-detail">
                <div className="movie-header">
                    <h1>{currentMovie.title}</h1>
                    <div className="rating-section">
                        <h4 className="rating">
                            ⭐ {currentMovie.rating ? currentMovie.rating.toFixed(1) : 'N/A'}/10
                        </h4>
                        <button className="rate-button" onClick={handleOpenModal}>Rate it</button>
                        <button className="watchlist-button" onClick={addToWatchlist}>+ Watchlist</button>
                    </div>
                </div>

                <div className="movie-content">
                    <img
                        className="movie-image"
                        src={'/images' + currentMovie.path} 
                        alt={currentMovie.title}
                    />
                    <div className="movie-info">
                        <p className="description">{currentMovie.description}</p>
                        <p><strong>Directors:</strong> {currentMovie.director}</p>
                        <p><strong>Writers:</strong> {currentMovie.writers}</p>
                        <p><strong>Actors:</strong> {currentMovie.actors}</p>
                        <p><strong>Type:</strong> {currentMovie.type}</p>
                    </div>
                </div>
                <RatingModal
                    isOpen={isModalOpen}
                    onClose={handleCloseModal}
                    onSubmit={handleRatingSubmit}
                />
            </div>
        </div>
    );
}

export default MovieDetail;
