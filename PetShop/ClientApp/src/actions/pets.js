import * as api from "../api/index";

export const getPets = () => async (dispatch) => {
  try {
    const { data } = await api.fetchPets();
    dispatch({ type: "FETCH_ALL", payload: data });
  } catch (error) {
    console.log(error.message);
  }
};
