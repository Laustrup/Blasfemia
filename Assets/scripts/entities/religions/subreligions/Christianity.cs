using System.Collections.Generic;
using religions/Religion;
using commandments;

namespace religions;

public class Christianity : Religion {
    
    public Christianity(string title, string description, string symbolURL) : base(title,description,symbolURL) {

    }

    private List<Commandment> addCommandments() {
        commandments.add(new Charity());
    }
}