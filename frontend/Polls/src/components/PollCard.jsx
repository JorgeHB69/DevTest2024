import {useEffect, useState} from "react";


export default function PollCard({title, options}) {
    const [totalVotes, setTotalVotes] = useState()

    useEffect(() => {
        let counter = 0;
        options.map(item => counter += item.votes)
        setTotalVotes(counter);
    }, []);

    return(
        <div className="p-5 border border-black">
            <div className="flex flex-row justify-between">
                <label className="font-bold">{title}</label>
                <a className="cursor-pointer text-blue-500">Vote</a>
            </div>

            <div>
                {options.map(item => <div className="flex flex-row justify-between">
                    <label>{item.name}</label>
                    <label>{(item.votes * 100) / totalVotes}</label>
                </div>)}
                <div className="w-full flex justify-end">
                    <label>
                        Total Votes: {totalVotes}
                    </label>
                </div>
            </div>
        </div>
    )
}