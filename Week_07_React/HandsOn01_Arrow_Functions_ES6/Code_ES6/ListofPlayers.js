import React from "react";

const ListofPlayers = () => {
  const players = [
    { name: "Mr. Alex", score: 100 },
    { name: "Mr. Jack", score: 55 },
    { name: "Mr. Steve", score: 75 },
    { name: "Mr. Samuel", score: 55 },
    { name: "Mr. Michael", score: 95 },
    { name: "Mr. Sidsriram", score: 50 },
    { name: "Mr. Bobby", score: 60 },
    { name: "Mr. Markram", score: 85 }
  ];

  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>List of Players</h2>
      {players.map((player, index) => (
        <p key={index}>{player.name} - {player.score}</p>
      ))}

      <h2>List of Players having score less than 70</h2>
      {lowScorers.map((player, index) => (
        <p key={index}>{player.name} - {player.score}</p>
      ))}
    </div>
  );
};

export default ListofPlayers;
