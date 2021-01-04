/*eslint-disable*/
import React from "react";
// react components for routing our app without refresh
import { Link } from "react-router-dom";
import { useLocation } from "react-router-dom";

// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import Tooltip from "@material-ui/core/Tooltip";
import Favorite from "@material-ui/icons/Favorite";
// @material-ui/icons
import { Apps, CloudDownload } from "@material-ui/icons";

// core components
import CustomDropdown from "components/CustomDropdown/CustomDropdown.js";
import Button from "components/CustomButtons/Button.js";

import styles from "assets/jss/material-kit-react/components/headerLinksStyle.js";

const useStyles = makeStyles(styles);

export default function HeaderLinks(props) {
  const classes = useStyles();

  const HeaderView = () => {
    const location = useLocation();
    return location.pathname;
  };

  const getAuth = () => {
    let auth;
    if (HeaderView() === "/home") {
      auth = (
        <React.Fragment>
          <Link to="/profile" style={{ color: "#000" }}>
            <Button color="transparent" className={classes.navLink}>
              <i className={`${classes.socialIcons} material-icons`}>face</i>
            </Button>
          </Link>

          <Link to="/login" style={{ color: "#000" }}>
            <Button color="transparent" className={classes.navLink}>
              Logout
            </Button>
          </Link>
        </React.Fragment>
      );
    } else if (HeaderView() === "/profile") {
      auth = (
        <React.Fragment>
          <Link to="/home" style={{ color: "#000" }}>
            <Button color="transparent" className={classes.navLink}>
              Home
            </Button>
          </Link>

          <Link to="/login" style={{ color: "#000" }}>
            <Button color="transparent" className={classes.navLink}>
              Logout
            </Button>
          </Link>
        </React.Fragment>
      );
    }

    if (HeaderView() === "/register") {
      auth = (
        <React.Fragment>
          <Link to="/login" style={{ color: "#FFF" }}>
            <Button color="transparent" className={classes.navLink}>
              Login
            </Button>
          </Link>
        </React.Fragment>
      );
    } else if (HeaderView() === "/login" || HeaderView() === "/") {
      auth = (
        <React.Fragment>
          <Link to="/register" style={{ color: "#FFF" }}>
            <Button color="transparent" className={classes.navLink}>
              Register
            </Button>
          </Link>
        </React.Fragment>
      );
    }
    return auth;
  };
  const auth = getAuth();

  return (
    <List className={classes.list}>
      <ListItem className={classes.listItem}>{auth}</ListItem>

      <ListItem className={classes.listItem}>
        <Tooltip
          id="instagram-facebook"
          title="Follow us on facebook"
          placement={window.innerWidth > 959 ? "top" : "left"}
          classes={{ tooltip: classes.tooltip }}
        >
          <Button
            color="transparent"
            href="#"
            target="_blank"
            className={classes.navLink}
          >
            <i className={classes.socialIcons + " fab fa-facebook"} />
          </Button>
        </Tooltip>
      </ListItem>
      <ListItem className={classes.listItem}>
        <Tooltip
          id="instagram-tooltip"
          title="Follow us on instagram"
          placement={window.innerWidth > 959 ? "top" : "left"}
          classes={{ tooltip: classes.tooltip }}
        >
          <Button
            color="transparent"
            href="#"
            target="_blank"
            className={classes.navLink}
          >
            <i className={classes.socialIcons + " fab fa-instagram"} />
          </Button>
        </Tooltip>
      </ListItem>
    </List>
  );
}
