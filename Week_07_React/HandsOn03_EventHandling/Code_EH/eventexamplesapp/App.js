import React, { useState } from "react";
import CurrencyConvertor from "./CurrencyConvertor";

function App() {
  const [count, setCount] = useState(0);

  const sayHello = () => {
    alert("Hello! This is a static message.");
  };

  const handleIncrement = () => {
    setCount(prev => prev + 1);
    sayHello(); // multiple method invocation
  };

  const handleDecrement = () => {
    setCount(prev => prev - 1);
  };

  const sayWelcome = (message) => {
    alert(message);
  };

  const handleClickEvent = (e) => {
    alert("I was clicked");
  };

  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>
      <h1>Event Examples App</h1>

      <h2>Counter: {count}</h2>
      <button onClick={handleIncrement}>Increment</button>{" "}
      <button onClick={handleDecrement}>Decrement</button>

      <hr />

      <button onClick={() => sayWelcome("Welcome!")}>Say Welcome</button>

      <hr />

      <button onClick={handleClickEvent}>OnPress</button>

      <hr />

      <CurrencyConvertor />
    </div>
  );
}

export default App;
