import buildApiUrl from '@/utils/helpers/build-api-url';

export const API_ROUTES = {
  login: () => buildApiUrl('auth', 'login'),
  me: () => buildApiUrl('auth', 'me'),
};
