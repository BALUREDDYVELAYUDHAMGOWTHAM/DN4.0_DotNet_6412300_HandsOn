import React from "react";
import  "./App.css";
const IndianPlayers = () => {
  const allPlayers = ["Mr. Hardick", "Mr. Dhoni", "Mr. Rahul", "Mr. Virat", "Mr. Rohit", "Mr. Iyer"];

  // Destructuring for odd and even
  const oddPlayers = allPlayers.filter((_, index) => index % 2 === 0);
  const evenPlayers = allPlayers.filter((_, index) => index % 2 !== 0);

  // Declare two arrays
  const T20players = ["Mr. Virat", "Mr. Rohit", "Mr. Bumrah"];
  const RanjiTrophyPlayers = ["Mr. Dhoni", "Mr. Iyer", "Mr. Jadeja"];

  // Merge using spread operator
  const mergedPlayers = [...T20players, ...RanjiTrophyPlayers];

  return (
    <div className="IndianPlayers">
      <h2>Odd Team Players</h2>
      {oddPlayers.map((player, index) => (
        <p key={index}>{player}</p>
      ))}

      <h2>Even Team Players</h2>
      {evenPlayers.map((player, index) => (
        <p key={index}>{player}</p>
      ))}

      <h2>Merged Player List (T20 + Ranji)</h2>
      {mergedPlayers.map((player, index) => (
        <p key={index}>{player}</p>
      ))}
    </div>
  );
};

export default IndianPlayers;
