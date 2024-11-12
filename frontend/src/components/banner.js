import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { Link } from 'react-router-dom';
import { Carousel } from 'react-bootstrap';
import './banner.css';
import React, { useState, useEffect } from 'react';


const API_BASE_URL = "http://localhost:5057";


// const bannerResult = [
//   {
//     movieName: "Movie One",
//     description: "An exciting adventure about courage and resilience.",
//     imagePath: "https://image.tmdb.org/t/p/original/rijaG2Z2XEeIUfWUn4fzmzTVCuK.jpg"
//   },
//   {
//     movieName: "Movie Two",
//     description: "A heartwarming story of friendship and discovery.",
//     imagePath: "https://image.tmdb.org/t/p/original/rijaG2Z2XEeIUfWUn4fzmzTVCuK.jpg"
//   },
//   {
//     movieName: "Movie Three",
//     description: "An action-packed journey through the wild unknown.",
//     imagePath: "https://image.tmdb.org/t/p/original/rijaG2Z2XEeIUfWUn4fzmzTVCuK.jpg"
//   }
// ];

// const trendingResult = [
//   {
//     id: 1,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 2,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   },
//   {
//     id: 3,
//     poster_path: "https://image.tmdb.org/t/p/original/k42Owka8v91trK1qMYwCQCNwJKr.jpg"
//   }
// ];



function Banner() {


  const [trendingResult, setTrendingResult] = useState([]);
  const [bannerResult, setBannerResult] = useState([]);
  const [actionResult, setActionResult] = useState([]);

  // Function to fetch data from the API based on tag
  const fetchMoviesByTag = async (tag) => {
    try {
      const response = await fetch(`http://localhost:5057/movies/${tag}`);
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
    <div>
      <Navbar expand="lg" fixed="top">
        <Container fluid>
          <Navbar.Brand as={Link} to="/">MovieScore</Navbar.Brand>
          <Navbar.Toggle aria-controls="navbarNav" />
          <Navbar.Collapse id="navbarNav">
            <Nav className="ms-auto">
              <Nav.Link as={Link} to="/search">Search</Nav.Link>
              <Nav.Link as={Link} to="/watchlist">Watchlist</Nav.Link>
              <Nav.Link as={Link} to="/login">Login</Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
      <div className="carousel-container">
        <Carousel>
          {bannerResult.map((banner, index) => (
            <Carousel.Item key={index}>
              <img
                className="d-block w-100"
                src={'/images'+banner.path}
                alt={`${banner.movieName} slide`}
              />
              <Carousel.Caption>
                <h3>{banner.movieName}</h3>
                <p>{banner.description}</p>
              </Carousel.Caption>
            </Carousel.Item>
          ))}
        </Carousel>
      </div>
      <div className="contain mt-3 p-3">
        <div className="row">
          <h5 className="text-white">Trending Movies</h5>
          <div className="rowposter mt-3 p-3">
            {trendingResult.map((b) => (
              <Link to={`/movie/${b.id}`} key={b.id}>
                <img
                  src={'/images'+b.path}
                  className="rowing largeposter"
                  alt="Movie Poster"
                />
              </Link>
            ))}
          </div>
        </div>
      </div>
      <div className="contain mt-3 p-3">
        <div className="row">
          <h5 className="text-white">Action Movies</h5>
          <div className="rowposter mt-3 p-3">
            {actionResult.map((b) => (
              <Link to={`/movie/${b.id}`} key={b.id}>
                <img
                  src={'/images'+b.path}
                  className="rowing largeposter"
                  alt="Movie Poster"
                />
              </Link>
            ))}
          </div>
        </div>
      </div>
    </div>
  );
}

export default Banner;