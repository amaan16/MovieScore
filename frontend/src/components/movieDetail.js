import React, { useContext } from 'react';
import { MovieContext } from '../movieContext';




function MovieDetail() {
    const { selectedMovie } = useContext(MovieContext);

    if (!selectedMovie) return <p>No movie selected</p>;
    return (
        <div></div>
      );

}

export default MovieDetail;