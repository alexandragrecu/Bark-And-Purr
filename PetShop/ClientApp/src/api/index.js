import axios from "axios";

const url = "https://localhost:44390/api";

export const fetchProducts = () => axios.get(`${url}/Products/all`);
