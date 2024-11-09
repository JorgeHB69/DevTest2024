
import TextField from "../components/TextField.jsx";
import {useState} from "react";


export default function () {
    const [index, setIndex] = useState(0);

    const pollMock = [
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
    ];

    return(
        <div className="ml-40 mr-40 mt-40 mb-40 p-5 space-y-3 border border-black bg-gray-200">
            <label className="font-bold">New Poll</label>
            <TextField type="text" title="Name" placeholder="some name"></TextField>

            <label className="font-semibold">Options:</label>
            <br/>
            <div className="flex flex-col">
                <label for="options"></label>
            {pollMock[0].options.map(
                item => <div>
                    <input type="radio" key="index" name={item.name}/>
                    <label>{item.name}</label>
                </div>
            )}
            </div>

            <div className="w-full flex flex-row space-x-20 justify-end">
                <button className="text-blue-500 cursor-pointer">Cancel</button>
                <button className="text-blue-500 cursor-pointer">Save</button>
            </div>
        </div>
    )
}