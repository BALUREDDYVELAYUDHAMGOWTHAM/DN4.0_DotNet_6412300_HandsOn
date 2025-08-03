import React from "react";
import ListofPlayers from "./ListofPlayers";
import IndianPlayers from "./IndianPlayers";

function App() {
  const flag = false; // change to false to show only IndianPlayers

  return (
    <div className="App">
      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
