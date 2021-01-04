const reducer = (pets = [], action) => {
  switch (action.type) {
    case "FETCH_ALL":
      return action.payload;
    default:
      return pets;
  }
};

export default reducer;
