import './App.css';
import Banner from './components/banner';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import MovieDetail from './components/movieDetail';
import React, { useState, useEffect, useContext } from 'react';
import { MovieContext } from './movieContext';



const API_BASE_URL = "https://moviescorebackend-abbscmgzexfdfhg0.northcentralus-01.azurewebsites.net";


function App() {
  const [trendingResult, setTrendingResult] = useState([]);
  const [bannerResult, setBannerResult] = useState([]);
  const [actionResult, setActionResult] = useState([]);

  // Function to fetch all movies from the API
  const fetchAllMovies = async () => {
    try {
      const response = await fetch(API_BASE_URL + '/movies');
      if (!response.ok) {
        throw new Error('Error fetching movies data');
      }
      const data = await response.json();
      return data;
    } catch (error) {
      console.error('Failed to fetch movies:', error);
      return [];
    }
  };

  useEffect(() => {
    // Fetch all movies and process them into separate lists
    const fetchAndProcessMovies = async () => {
      const tempMovies = await fetchAllMovies();
      
      console.log(tempMovies);

      // Separate movies by tags
      const trending = tempMovies.filter(movie => movie.tag === 'trending');
      const banner = tempMovies.filter(movie => movie.tag === 'banner');
      const action = tempMovies.filter(movie => movie.tag === 'action');

      // Update the state with filtered movies
      setTrendingResult(trending);
      setBannerResult(banner);
      setActionResult(action);
    };

    fetchAndProcessMovies();

  }, []);

  return (
    <div className='App'>
      <Router>
        <Routes>
          <Route path="/" element={<Banner trendingResult={trendingResult} bannerResult={bannerResult} actionResult={actionResult} />} />
          <Route path="/movie" element={<MovieDetail />} />
          <Route path="/watchlist" element={<MovieDetail />} />
        </Routes>
      </Router></div>
  );
}

export default App;
