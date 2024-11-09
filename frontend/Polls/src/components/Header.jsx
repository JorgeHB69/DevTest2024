import PollCard from "./PollCard.jsx";
import {useEffect, useState} from "react";

export default function Header({title}) {
    return(
        <div className="h-40 w-full bg-gray-200 pl-36 pr-36 pt-24">
            <h1 className="font-bold text-lg">{title}</h1>
        </div>
    )
}