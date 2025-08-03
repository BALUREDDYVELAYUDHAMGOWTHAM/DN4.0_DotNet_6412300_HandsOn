import React from "react";
import BookDetails from "./Components/BookDetails";
import BlogDetails from "./Components/BlogDetails";
import CourseDetails from "./Components/CourseDetails";

function App() {
  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>
      <h1>📚 Blogger App</h1>

      {/* Flexbox container to align components side by side */}
      <div style={{ display: "flex", justifyContent: "space-between", gap: "20px" }}>
        <div style={{ flex: 1 }}>
          <BookDetails />
        </div>
        <div style={{ flex: 1 }}>
          <BlogDetails />
        </div>
        <div style={{ flex: 1 }}>
          <CourseDetails />
        </div>
      </div>
    </div>
  );
}

export default App;
