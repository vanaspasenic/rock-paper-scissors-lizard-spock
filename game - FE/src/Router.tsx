import { Navigate, Route, Routes } from "react-router-dom";
import { Game } from "./pages/Game";

const Router = () => {
    return (
        <Routes>
            <Route path="/" element={<Navigate to="/game" replace />} />
            <Route path="/game" element={<Game />} />
        </Routes>
    )
}

export default Router;
