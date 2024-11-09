

export default function TextField({title, type, placeholder, register, error}){
    return (
        <div>
            <div className="flex flex-row space-x-5 items-center">
                <label className="font-semibold">{title}: </label>
                <input className="w-full h-10 border border-black pl-3" {...register} type={type} placeholder={placeholder}/>
            </div>
            {error && <label className="text-red-600 text-sm">{error}</label>}
        </div>
    )
}