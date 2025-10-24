import { Navigate, Route, Routes } from 'react-router-dom';

import AuthContentProvider from '@/contexts/authentication/auth-context-provider';
import Dashboard from '@/pages/dashboard/Dashboard.tsx';
import Login from '@/pages/login/login.tsx';
import ProtectedRoute from '@/routing/ProtectedRoute.tsx';

const App = () => {
  return (
    <AuthContentProvider>
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route element={<ProtectedRoute />}>
          <Route path="/dashboard" element={<Dashboard />} />
          <Route path="*" element={<Navigate to="/dashboard" replace />} />
        </Route>
      </Routes>
    </AuthContentProvider>
  );
};

export default App;
