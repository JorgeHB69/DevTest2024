import TextField from "../components/TextField.jsx";
import {useState} from "react";
import {useForm} from "react-hook-form";

export default function AddNewPollForm() {
    const { register, handleSubmit, watch, formState: { errors } } = useForm();
    const [options, setOptions] = useState([]);

    const handleOptionsAdd = () => {
        setOptions([...options, {}])
    }

    const onSubmit = (data) => console.log(data);

    return(
        <div className="ml-40 mr-40 mt-40 mb-40 p-5 space-y-3 border border-black bg-gray-200">
            <form onSubmit={handleSubmit(onSubmit)}>
            <label className="font-bold">New Poll</label>
            <TextField
                register={register("name",
                    {
                        required: {value: true, message: "Name required"},
                        pattern: {value: /^[A-Za-z0-9]+$/, message: "Name not follow the format"},
                    })}
                type="text" title="Name"
                placeholder="some name"
                error={errors.name?.message}
            ></TextField>

            <label className="font-semibold">Options:</label>
            <br/>
            {options.map(
                (item, index) => <TextField
                    register={register(`option${index}`,
                        {
                            required: {value: true, message: "Name required"},
                            pattern: {value: /^[A-Za-z0-9]+$/, message: "Name not follow the format"},
                        })}
                    key={index} type="text" title={(index + 1).toString()}
                    error={errors.option?.message}
                >
                </TextField>)
            }

            <button className="text-blue-500 cursor-pointer" onClick={handleOptionsAdd}>Add Option</button>

            <div className="w-full flex flex-row space-x-20 justify-end">
                <button className="text-blue-500 cursor-pointer">Cancel</button>
                <button className="text-blue-500 cursor-pointer">Save</button>
            </div>
            </form>
        </div>
    )
}