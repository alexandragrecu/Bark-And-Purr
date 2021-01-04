import React from "react";
import Order from "./Order";

// core components
import GridContainer from "components/Grid/GridContainer.js";

export default function Orders() {
  return (
    <GridContainer justify="center">
      <Order />
      <Order />
      <Order />
      <Order />
      <Order />
    </GridContainer>
  );
}
