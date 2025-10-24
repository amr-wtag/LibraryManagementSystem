const getAuthToken = (cookieName = 'token') => {
  const allCookies = document.cookie.split(';');

  console.log({ allCookies });

  const targetCookie = allCookies.find((cookie) => {
    return cookie.trim().startsWith(`${cookieName}=`);
  });

  if (targetCookie) {
    return targetCookie.split('=')[1];
  }

  return null;
};

export default getAuthToken;
