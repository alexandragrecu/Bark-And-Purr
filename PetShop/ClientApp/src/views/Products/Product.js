import React from "react";
import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";

export default function Product() {
  return (
    <GridItem xs={12} sm={12} md={4}>
      <h3>Acesta este un produs</h3>
      <Button color="primary" round>
        Delete Product
      </Button>
    </GridItem>
  );
}
