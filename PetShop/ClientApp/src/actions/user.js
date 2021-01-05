import * as api from "../api/index";

export const loginUser = (loginData) => async (dispatch) => {
  try {
    const { data } = await api.loginUser(loginData);
    dispatch({ type: "LOGIN", payload: data });
  } catch (error) {
    console.log(error);
  }
};
