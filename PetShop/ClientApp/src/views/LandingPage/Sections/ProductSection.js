import React from "react";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

// @material-ui/icons
// core components
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";
import Product from "./Product";

import styles from "assets/jss/material-kit-react/views/landingPageSections/productStyle.js";

const useStyles = makeStyles(styles);

const ProductSection = (props) => {
  const classes = useStyles();
  return (
    <div className={classes.section}>
      <GridContainer justify="center">
        <GridItem xs={12} sm={12} md={8}>
          <h2 className={classes.title}>
            Your BEST friend deserves the BEST products!
          </h2>
          <h5 className={classes.description}>
            Your dog and cat deserve all best products from us! We help you to
            make your little friend so happy!
          </h5>
        </GridItem>
      </GridContainer>
      <div>
        <GridContainer>
          {props.products.map((product) => (
            <Product key={product.id} product={product} />
          ))}
          {console.log(props.products)}
        </GridContainer>
      </div>
    </div>
  );
};

export default ProductSection;
