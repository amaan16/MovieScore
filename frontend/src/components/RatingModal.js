import React from 'react';
import './RatingModal.css';

function RatingModal({ isOpen, onClose, onSubmit }) {
    const [rating, setRating] = React.useState(0);

    if (!isOpen) return null;

    const handleStarClick = (value) => {
        setRating(value);
    };

    const handleSubmit = () => {
        onSubmit(rating);
        onClose();
    };

    const renderStars = () => {
        let stars = [];
        for (let i = 1; i <= 10; i++) {
            stars.push(
                <span
                    key={i}
                    className={`star ${i <= rating ? 'filled' : ''}`}
                    onClick={() => handleStarClick(i)}
                >
                    ★
                </span>
            );
        }
        return stars;
    };

    return (
        <div className="modal-overlay">
            <div className="modal-content">
                <h2>Rate this Movie</h2>
                <div className="stars-container">
                    {renderStars()}
                </div>
                <div className="rating-display">
                    <span>{rating}/10</span>
                </div>
                <button onClick={handleSubmit}>Submit</button>
                <button onClick={onClose}>Cancel</button>
            </div>
        </div>
    );
}

export default RatingModal;
