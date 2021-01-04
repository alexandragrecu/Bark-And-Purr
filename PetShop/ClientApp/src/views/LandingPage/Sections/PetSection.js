import React from "react";
import Pet from "./Pet";

// nodejs library that concatenates classes
import classNames from "classnames";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

// @material-ui/icons

// core components
import GridContainer from "components/Grid/GridContainer.js";

import styles from "assets/jss/material-kit-react/views/landingPageSections/teamStyle.js";

const useStyles = makeStyles(styles);

export default function PetSection(props) {
  const classes = useStyles();

  return (
    <div className={classes.section}>
      <h2 className={classes.title}>
        Want to adopt a pet? Choose your future little friend!
      </h2>
      <div>
        <GridContainer>
          {props.pets.map((pet) => (
            <Pet key={pet.id} pet={pet} />
          ))}
        </GridContainer>
      </div>
    </div>
  );
}
