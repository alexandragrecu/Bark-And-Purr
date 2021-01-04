import React from "react";
import Pet from "./Pet";

// core components
import GridContainer from "components/Grid/GridContainer.js";

export default function Pets() {
  return (
    <GridContainer justify="center">
      <Pet />
      <Pet />
      <Pet />
      <Pet />
      <Pet />
      <Pet />
    </GridContainer>
  );
}
