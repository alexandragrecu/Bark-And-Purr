import React from "react";
import GridItem from "components/Grid/GridItem.js";
import Button from "components/CustomButtons/Button.js";

export default function Order() {
  return (
    <GridItem xs={12} sm={12} md={4}>
      <h3>Aceasta este comanda ta:</h3>

      <Button color="primary" round>
        Send order
      </Button>
    </GridItem>
  );
}
