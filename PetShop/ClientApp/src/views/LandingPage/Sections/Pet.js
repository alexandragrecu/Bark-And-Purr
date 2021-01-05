import React from "react";
import PropTypes from "prop-types";
// nodejs library that concatenates classes
import classNames from "classnames";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";
import Card from "components/Card/Card.js";
import CardBody from "components/Card/CardBody.js";
import CardFooter from "components/Card/CardFooter.js";

import styles from "assets/jss/material-kit-react/views/landingPageSections/teamStyle.js";

import picture1 from "assets/img/dog_cat.jpg";

const useStyles = makeStyles(styles);

const Pet = (props) => {
  const classes = useStyles();
  const imageClasses = classNames(
    classes.imgRaised,
    classes.imgRoundedCircle,
    classes.imgFluid
  );
  return (
    <React.Fragment>
      <GridItem xs={12} sm={12} md={4}>
        <Card plain>
          <GridItem xs={12} sm={12} md={6} className={classes.itemGrid}>
            <img src={picture1} alt="..." className={imageClasses} />
          </GridItem>
          <h4 className={classes.cardTitle}>
            {props.petCategory}
            <br />
            <small className={classes.smallTitle}>{props.breed}</small>
          </h4>
          <CardBody>
            <p className={classes.description}>
              weight: {props.weight} {", "} height: {props.height} {", "}
              age:
              {props.age}{" "}
            </p>
          </CardBody>
          <CardFooter className={classes.justifyCenter}>
            <Button color="primary" round>
              Adopt!
            </Button>
          </CardFooter>
        </Card>
      </GridItem>
    </React.Fragment>
  );
};

Pet.propTypes = {
  petCategory: PropTypes.string,
  weight: PropTypes.number,
  breed: PropTypes.string,
  height: PropTypes.number,
  age: PropTypes.number,
};

export default Pet;
