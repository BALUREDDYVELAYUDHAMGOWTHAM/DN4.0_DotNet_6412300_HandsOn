import React, { useState } from "react";

function CurrencyConvertor() {
  const [rupees, setRupees] = useState("");

  const handleSubmit = () => {
    if (!rupees || isNaN(rupees)) {
      alert("Please enter a valid number in INR");
      return;
    }

    const valueInEuro = parseFloat(rupees) / 90; // 1 Euro = ₹90
    const message = `₹${rupees} = €${valueInEuro.toFixed(2)}`;
    alert(message); // ✅ Alert message as required
  };

  return (
    <div>
      <h2>Currency Convertor (INR to Euro)</h2>
      <input
        type="number"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
        placeholder="Enter amount in INR"
      />
      <button onClick={handleSubmit}>Convert</button>
    </div>
  );
}

export default CurrencyConvertor;
