const API_BASE_URL = process.env.NEXT_PUBLIC_API_URL;

const API_ENDPOINTS = {
  books: API_BASE_URL + '/book',
  login: API_BASE_URL + '/auth/login',
};

export default API_ENDPOINTS;
