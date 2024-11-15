import { Link } from 'react-router-dom';
import { Carousel } from 'react-bootstrap';
import './banner.css';
import React, { useContext } from 'react';
import { MovieContext } from '../movieContext';
import NavBar from './navBar';


function Banner({ trendingResult, bannerResult, actionResult }) {
  const { setSelectedMovie } = useContext(MovieContext);

  return (
    <div>
      <NavBar />
      <div className="carousel-container">
        <Carousel>
          {bannerResult.map((banner, index) => (
            <Carousel.Item key={index}>
                            <Link to={`/movie`} key={banner.id} onClick={() => setSelectedMovie(banner)}>
              <img
                className="d-block w-100"
                src={'/images' + banner.backdropPath}
                alt={`${banner.movieName} slide`}
              /></Link>
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
              <Link to={`/movie`} key={b.id} onClick={() => setSelectedMovie(b)}>
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