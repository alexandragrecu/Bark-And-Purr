import axios from "axios";

const url = "https://localhost:44390/api";

export const fetchProducts = () => axios.get(`${url}/Products/all`);
export const fetchPets = () => axios.get(`${url}/Pets/all`);
