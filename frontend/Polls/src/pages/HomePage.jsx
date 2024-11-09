import Header from "../components/Header.jsx";
import PollCard from "../components/PollCard.jsx";
import {useEffect, useState} from "react";
import axios from "axios";


export default function HomePage() {
    const [polls, setPolls] = useState([
        {
            "name": "Prueba",
            "options": [
                {
                    "index": 1,
                    "name": "C#",
                    "votes": 3,
                    "id": "74a4154a-f079-4b5d-9cd6-5bc8c3489603",
                    "isActive": true,
                    "createdAt": "2024-11-09T11:26:23.4160143-04:00"
                },
                {
                    "index": 2,
                    "name": "Python",
                    "votes": 5,
                    "id": "550bc5c1-a5f9-43d7-84a5-7c52c775f149",
                    "isActive": true,
                    "createdAt": "2024-11-09T11:26:23.416149-04:00"
                }
            ],
            "id": "1f351232-8c84-4a65-8933-8a28fdb7fdef",
            "isActive": true,
            "createdAt": "2024-11-09T11:26:23.4164498-04:00"
        }
    ]);

    useEffect(() => {
        axios("http://localhost:5263/api/v1/Poll")
            .then(response => setPolls(response.data))
            .catch(e => console.error(e));
    }, []);

    return (
        <div>
            <Header title="Online Polls"></Header>
            <div className="container">
                <div className="flex justify-between">
                    <label>Poll List</label>
                    <a className="text-blue-500 cursor-pointer" href="/add-poll">Add new</a>
                </div>
                {polls.map(
                    item =>
                        <PollCard title={item.name} options={item.options}></PollCard>
                )}
            </div>
        </div>
    )
}