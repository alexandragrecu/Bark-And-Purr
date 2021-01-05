import React from "react";
import { useSelector } from "react-redux";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

import "assets/scss/material-kit-react.scss?v=1.9.0";

import LoginPage from "views/LoginPage/LoginPage.js";
import RegisterPage from "views/RegisterPage/RegisterPage.js";
import LandingPage from "views/LandingPage/LandingPage.js";
import ProfilePage from "views/ProfilePage/ProfilePage.js";

const App = () => {
  return (
    <React.Fragment>
      <Router>
        <Switch>
          <Route path="/home" component={LandingPage} />
          <Route path="/register" component={RegisterPage} />
          <Route path="/profile" component={ProfilePage} />
          <Route path="/" exact component={LoginPage} />
          <Route path="/login" component={LoginPage} />
        </Switch>
      </Router>
    </React.Fragment>
  );
};

export default App;
