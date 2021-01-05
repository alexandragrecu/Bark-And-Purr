import axios from "axios";

const token = require("../actions/user");
console.log("acesta e tokenul utiliz");
console.log(token);

const url = "https://localhost:44390/api";

export const fetchProducts = () => axios.get(`${url}/Products/all`);
export const fetchPets = () => axios.get(`${url}/Pets/all`);
export const loginUser = (loginData) =>
  axios.post(`${url}/Auth/login`, loginData);
