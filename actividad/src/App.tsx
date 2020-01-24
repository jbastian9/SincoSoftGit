import React, { Component } from "react";
import { Container } from "react-bootstrap";
import Home from "./pages/Home";
import { BrowserRouter, Route } from "react-router-dom";
import User from "./pages/User";
import Contact from "./pages/Contact";
import Mail from "./pages/Mail";

const App: React.FC = () => {
  return (
    <Container fluid style={{ backgroundColor: "black" }}>
      <BrowserRouter>
        <Home />
        <Route path="/User" exact component={User} />
        <Route path="/Contact" exact component={Contact} />
        <Route path="/Mail" exact component={Mail} />
      </BrowserRouter>
    </Container>
  );
};

export default App;
