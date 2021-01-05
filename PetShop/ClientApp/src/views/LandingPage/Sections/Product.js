import React from "react";
import PropTypes from "prop-types";
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
          title={props.name}
          description={props.petType}
          cost={props.cost}
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

Product.propTypes = {
  name: PropTypes.string,
  petType: PropTypes.string,
  cost: PropTypes.number,
};

export default Product;
