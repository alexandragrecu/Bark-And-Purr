import React from "react";
import { useSelector } from "react-redux";
import { Link } from "react-router-dom";
// nodejs library that concatenates classes
import classNames from "classnames";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";
// @material-ui/icons

// core components
import Header from "components/Header/Header.js";
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";
import HeaderLinks from "components/Header/HeaderLinks.js";
import Parallax from "components/Parallax/Parallax.js";

import styles from "assets/jss/material-kit-react/views/landingPage.js";

// Sections for this page
import ProductSection from "./Sections/ProductSection.js";
// import PetSection from "./Sections/PetSection.js";

const dashboardRoutes = [];

const useStyles = makeStyles(styles);

export default function LandingPage(props) {
  const classes = useStyles();
  const { ...rest } = props;

  // const products = useSelector((state) => state.products);
  // if (!products) {
  //   console.log(products);
  // } else {
  //   console.log("Nu avem produse");
  // }
  // const pets = useSelector((state) => state.pets);
  const user = useSelector((state) => state.user);
  console.log("user + token");
  console.log(user.token);
  if (!user.token) {
    return (
      <React.Fragment>
        <div>Your data is incorrect! Please login again!!</div>;
        <Link to="/login">Login again</Link>
      </React.Fragment>
    );
  } else {
    return (
      <div>
        <Header
          color="transparent"
          routes={dashboardRoutes}
          brand="Bark & Purr"
          rightLinks={<HeaderLinks />}
          fixed
          changeColorOnScroll={{
            height: 400,
            color: "white",
          }}
          {...rest}
        />
        <Parallax filter image={require("assets/img/dogs.jpg")}>
          <div className={classes.container}>
            <GridContainer>
              <GridItem xs={12} sm={12} md={6}>
                <h1 className={classes.title}>
                  Happiness is having a puppy or kitten close to you!
                </h1>
                <h4>
                  Bark & Purr is an online shops for accessories for cats and
                  dogs. We are happy to offer you a wide range of products for
                  your best friend!
                </h4>
                <br />
                <Button
                  color="danger"
                  size="lg"
                  href="https://www.youtube.com/watch?v=0A2R27kCeD4&ab_channel=FunnyAnimals%27Life"
                  target="_blank"
                  rel="noopener noreferrer"
                >
                  <i className="fas fa-play" />
                  Watch and Smile!
                </Button>
              </GridItem>
            </GridContainer>
          </div>
        </Parallax>
        <div className={classNames(classes.main, classes.mainRaised)}>
          <div className={classes.container}>
            <ProductSection />

            {/* <PetSection /> */}
          </div>
        </div>
      </div>
    );
  }
}
