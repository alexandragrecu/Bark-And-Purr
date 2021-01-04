import React from "react";
// @material-ui/core components

// @material-ui/icons
import VerifiedUser from "@material-ui/icons/VerifiedUser";
// core components
import GridItem from "components/Grid/GridItem.js";
import InfoArea from "components/InfoArea/InfoArea.js";
import Button from "components/CustomButtons/Button.js";

const Product = (props) => {
  return (
    <React.Fragment>
      <GridItem xs={12} sm={12} md={4}>
        <InfoArea
          title={props.product.name}
          description={props.product.petType}
          cost={props.product.cost}
          icon={VerifiedUser}
          iconColor="success"
          vertical
        />
        <Button color="primary" round disabled>
          Buy now!
        </Button>
      </GridItem>
    </React.Fragment>
  );
};

export default Product;
