import { useMemo, type FC, type ReactNode } from 'react';

import AuthContext from '@/contexts/authentication/auth-context';
import useGetMe from '@/hooks/use-get-me';

interface AuthContentProviderProps {
  children: ReactNode;
}

const AuthContentProvider: FC<AuthContentProviderProps> = ({ children }) => {
  const { data: user, isLoading, isError } = useGetMe();

  const value = useMemo(
    () => ({ user, isAuthenticated: !!user, isLoading, isError }),
    [user, isLoading, isError]
  );

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};

export default AuthContentProvider;
