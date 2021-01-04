import React from "react";
import Product from "./Product";

// core components
import GridContainer from "components/Grid/GridContainer.js";

export default function Products() {
  return (
    <GridContainer justify="center">
      <Product />
      <Product />
      <Product />
      <Product />
      <Product />
    </GridContainer>
  );
}
