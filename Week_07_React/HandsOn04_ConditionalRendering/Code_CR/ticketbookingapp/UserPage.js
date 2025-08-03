import React from "react";

function UserPage() {
  const flights = [
    { id: 1, from: "Delhi", to: "Mumbai", time: "10:00 AM" },
    { id: 2, from: "Chennai", to: "Bangalore", time: "2:30 PM" },
    { id: 3, from: "Hyderabad", to: "Kolkata", time: "6:45 PM" },
  ];

  const handleBook = (flight) => {
    alert(`Ticket booked for flight from ${flight.from} to ${flight.to} at ${flight.time}`);
  };

  return (
    <div>
      <h2>Welcome, User!</h2>
      <h3>Available Flights</h3>
      <ul>
        {flights.map((flight) => (
          <li key={flight.id}>
            {flight.from} → {flight.to} at {flight.time}
            <button onClick={() => handleBook(flight)} style={{ marginLeft: "10px" }}>
              Book
            </button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default UserPage;
