import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";

// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";

// @material-ui/icons
// core components
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";
import Product from "./Product";

import { getProducts } from "../../../actions/products";

import styles from "assets/jss/material-kit-react/views/landingPageSections/productStyle.js";

const useStyles = makeStyles(styles);

const ProductSection = () => {
  const classes = useStyles();
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(getProducts());
  }, [dispatch]);

  const products = useSelector((state) => state.products);
  const pets = useSelector((state) => state.pets);
  if (products && pets) {
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
            {products.map((product) => (
              <Product
                key={product.id}
                name={product.name}
                cost={product.cost}
                petType={product.petType}
              />
            ))}
          </GridContainer>
        </div>
      </div>
    );
  }
};
export default ProductSection;
