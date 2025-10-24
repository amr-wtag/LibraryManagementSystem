const envVariables = import.meta.env;

const { VITE_APP_DOMAIN } = envVariables;

const BASE_API_URL = `${VITE_APP_DOMAIN}/api`;

type PathSegment = string | number | null | undefined;

const isValidSegment = (segment: PathSegment): segment is string | number => {
  if (segment === null || segment === undefined) {
    return false;
  }

  return !(typeof segment === 'string' && segment.trim() === '');
};

const buildApiUrl = (basePath: string, ...segments: PathSegment[]): string => {
  const parts = [basePath, ...segments].filter(isValidSegment).map(String);

  return `${BASE_API_URL}/${parts.join('/')}`;
};

export default buildApiUrl;
