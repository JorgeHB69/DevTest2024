import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";
import HomePage from "./pages/HomePage.jsx";
import AddNewPollForm from "./pages/AddNewPollForm.jsx";
import VoteForm from "./pages/VoteForm.jsx";

const router = createBrowserRouter([
    {
        path: "/",
        element: <HomePage></HomePage>,
    },

    {
        path: "/add-poll",
        element: <AddNewPollForm></AddNewPollForm>,
    },

    {
        path: "/vote",
        element: <VoteForm></VoteForm>,
    },
]);

createRoot(document.getElementById('root')).render(
  <StrictMode>
      <RouterProvider router={router} />
  </StrictMode>,
)
