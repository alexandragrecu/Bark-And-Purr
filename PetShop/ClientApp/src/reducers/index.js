import { combineReducers } from "redux";

import products from "./products";
import pets from "./pets";
import user from "./user";

export default combineReducers({ products, pets, user });
