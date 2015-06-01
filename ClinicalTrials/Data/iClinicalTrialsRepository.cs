using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrials.Data
{
    public interface IClinicalTrialsRepository
    {
        IQueryable<Topic> GetTopics();
        IQueryable<Topic> GetTopicsIncludingReplies();
        IQueryable<Reply> GetRepliesByTopic(int topicId);
        IQueryable<Group> GetGroups();
        IQueryable<FormElement> GetFormElementsByGroup(int groupId);
        //IQueryable<ProtocolFormElementOption> GetProtocolFormElementOptionsByFormElementId(int formElementId);
        IQueryable<Group> GetGroupsIncludingFormElements();
        IQueryable<Protocol> GetProtocols();
        IQueryable<ProtocolFormElementOption> GetProtocolFormElementOptions();
        

        bool Save();

        bool AddTopic(Topic newTopic);
        bool AddReply(Reply newReply);
        bool AddGroup(Group newGroup);
        bool AddFormElement(FormElement newFormElement);
        bool AddChildFormElement(ChildFormElement newChildFormElement);
        bool AddProtocol(Protocol newProtocol);
    }
}
