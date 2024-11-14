import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { Link } from 'react-router-dom';
import { Carousel } from 'react-bootstrap';
import './banner.css';
import React, { useContext } from 'react';
import { MovieContext } from '../movieContext';

const API_BASE_URL = "https://moviescorebackend-abbscmgzexfdfhg0.northcentralus-01.azurewebsites.net";

function Banner({ trendingResult, bannerResult, actionResult }) {
  const { setSelectedMovie } = useContext(MovieContext);

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
                src={'/images' + banner.path}
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
              <Link
                to="/movie"
                key={b.id}
                onClick={() => setSelectedMovie(b)}
              >
                <img
                  src={'/images' + b.path}
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
                  src={'/images' + b.path}
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