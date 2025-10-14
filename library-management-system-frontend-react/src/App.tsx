import {Navigate, Route, Routes} from "react-router-dom";

import Dashboard from "@/pages/dashboard/Dashboard.tsx";
import Login from "@/pages/login/login.tsx";

const App = () => {

    return (
        <Routes>
            <Route path="/dashboard" element={<Dashboard/>}/>
          <Route path="*" element={<Navigate to="/login" replace />} />
            <Route path='/login' element={<Login/>}/>
        </Routes>
    )
}

export default App;
