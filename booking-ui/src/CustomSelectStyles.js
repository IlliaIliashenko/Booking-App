export const customStyles = {
    option: (provided, state) => ({
        ...provided,
        borderBottom: "1px dotted pink",
        color: state.isSelected ? "blue" : "",
        fontSize: 16,
        backgroundColor: state.isSelected ? "#eee" : "",
        textAlign: "left",
        cursor: "pointer"
      }),
      container: base => ({
        ...base,
        width: "10%"
      }),
      control: base => ({
        ...base,
        height: 32,
        minHeight: 32,
        fontSize: 16,
        borderRadius: 0,
        width: "100%",
        textAlign: "left",
        cursor: "pointer"
      }),
      valueContainer: base => ({
        ...base,
        padding: 0,
        paddingLeft: 2
      })
    };