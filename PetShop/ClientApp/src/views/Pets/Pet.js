import React from "react";
import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";

export default function Pet() {
  return (
    <GridItem xs={12} sm={12} md={4}>
      <h3>Acesta e animalul tau preferat:</h3>
      <Button color="primary" round>
        Update pet
      </Button>
    </GridItem>
  );
}
