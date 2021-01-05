import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";

import { getPets } from "../../../actions/pets";

import Pet from "./Pet";
// nodejs library that concatenates classes
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

// @material-ui/icons

// core components
import GridContainer from "components/Grid/GridContainer.js";

import styles from "assets/jss/material-kit-react/views/landingPageSections/teamStyle.js";

const useStyles = makeStyles(styles);

export default function PetSection() {
  const classes = useStyles();

  const dispatch = useDispatch();
  useEffect(() => {
    // dispatch(getProducts());
    dispatch(getPets());
  }, [dispatch]);

  const pets = useSelector((state) => state.pets);
  const products = useSelector((state) => state.products);
  if (pets && products) {
    return (
      <div className={classes.section}>
        <h2 className={classes.title}>
          Want to adopt a pet? Choose your future little friend!
        </h2>
        <div>
          <GridContainer>
            {pets.map((pet) => (
              <Pet
                key={pet.id}
                petCategory={pet.petCategory}
                breed={pet.breed}
                weight={pet.weight}
                height={pet.height}
                age={pet.age}
              />
            ))}
          </GridContainer>
        </div>
      </div>
    );
  }
}
