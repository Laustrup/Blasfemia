using System.Collections;
using System.Collections.Generic;
using commandments;
using entities/BehaviourEntity;

namespace religions;

public class Religion : BehaviourEntity {

    protected string symbolURL {get; set;};

    protected List<Commandment> commandments {get;}

    public Religion(string title, string description, string symbolURL) : base(title,description) {
        this.symbolURL = symbolURL;
        commandments = new ArrayList();
    }

}