import './App.css';
import Banner from './components/banner';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import MovieDetail from './components/movieDetail';


import React, { useState, useEffect } from 'react';


const API_BASE_URL = "https://moviescorebackend-abbscmgzexfdfhg0.northcentralus-01.azurewebsites.net";


function App() {

  const [trendingResult, setTrendingResult] = useState([]);
  const [bannerResult, setBannerResult] = useState([]);
  const [actionResult, setActionResult] = useState([]);

  // Function to fetch data from the API based on tag
  const fetchMoviesByTag = async (tag) => {
    try {
      //todo: need to change to single api call, and process it in the frontend/client side
      const response = await fetch(API_BASE_URL + `/movies/${tag}`);
      if (!response.ok) {
        throw new Error(`Error fetching ${tag} data`);
      }
      const data = await response.json();
      return data;
    } catch (error) {
      console.error(`Failed to fetch ${tag}:`, error);
      return [];
    }
  };

  useEffect(() => {
    // Fetch each tag and set its respective state
    const fetchAllData = async () => {
      const trending = await fetchMoviesByTag('trending');
      setTrendingResult(trending);

      const banner = await fetchMoviesByTag('banner');
      setBannerResult(banner);

      const action = await fetchMoviesByTag('action');
      setActionResult(action);
    };

    fetchAllData();
  }, []);

  return (
    <div className='App'><Router>
      <Routes>
        <Route path="/" element={<Banner trendingResult={trendingResult} bannerResult={bannerResult} actionResult={actionResult} />} />
        <Route path="/movie" element={<MovieDetail />} />
        <Route path="/watchlist" element ={<MovieDetail />} />
      </Routes>
    </Router></div>
  );
}

export default App;
