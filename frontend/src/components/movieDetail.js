import React, { useContext , useState} from 'react';
import { MovieContext } from '../movieContext';
import './movieDetail.css';
import NavBar from './navBar';
import RatingModal from './RatingModal';




function MovieDetail() {
    const { selectedMovie } = useContext(MovieContext);
    const [isModalOpen, setIsModalOpen] = useState(false);

    const handleOpenModal = () => setIsModalOpen(true);
    const handleCloseModal = () => setIsModalOpen(false);

    const handleRatingSubmit = (rating) => {
        console.log(`Rated movie: ${rating}`);
        // Here, you could add logic to save the rating in the backend or state
    };

    console.log(selectedMovie)
    if (!selectedMovie) return <p>No movie selected</p>;
    return (
        <div className='background-container'>
            <NavBar />

            <div className="movie-detail">
                {/* Header section with title, rating, and watchlist button */}
                <div className="movie-header">
                    <h1>{selectedMovie.title}</h1>
                    <div className="rating-section">
                        <h4 className="rating">
                            ⭐ {selectedMovie.rating.toFixed(1)}/10   {/* ({ratingCount}) */}
                        </h4>                        
                        <button className="rate-button" onClick={handleOpenModal}>Rate it</button>
                        <button className="watchlist-button">+ Watchlist</button>
                    </div>
                </div>

                {/* Content section with image and details */}
                <div className="movie-content">
                    <img
                        className="movie-image"
                        src={'/images' + selectedMovie.path} // Assuming 'path' is the image URL
                        alt={selectedMovie.title}
                    />
                    <div className="movie-info">
                        <p className="description">{selectedMovie.description}</p>
                        <p><strong>Directors:</strong> {selectedMovie.director}</p>
                        <p><strong>Writers:</strong> {selectedMovie.writers}</p>
                        <p><strong>Actors:</strong> {selectedMovie.actors}</p>
                        <p><strong>Type:</strong> {selectedMovie.type}</p>
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

