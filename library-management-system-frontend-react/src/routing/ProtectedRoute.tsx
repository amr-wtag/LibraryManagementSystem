import { Navigate, Outlet } from 'react-router-dom';

import useAuth from '@/hooks/use-auth';

const ProtectedRoute = () => {
  const { isAuthenticated, isLoading } = useAuth();

  if (!isAuthenticated) {
    return <div>Loading...</div>;
  }

  return isAuthenticated ? <Outlet /> : <Navigate to="/login" replace />;
};

export default ProtectedRoute;
