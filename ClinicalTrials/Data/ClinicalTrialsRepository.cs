using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Web;

namespace ClinicalTrials.Data
{
    public class ClinicalTrialsRepository : IClinicalTrialsRepository
    {

        private ClinicalTrialsContext _ctx;

        public ClinicalTrialsRepository(ClinicalTrialsContext ctx)
        {
            _ctx = ctx;   
        }

        public IQueryable<Topic> GetTopics()
        {
            return _ctx.Topics;
        }

        public IQueryable<Protocol> GetProtocols()
        {
            return _ctx.Protocols;
        }

        public IQueryable<FormElementOption> GetFormElementOptions()
        {
            return _ctx.FormElementOptions;
        }

        public IQueryable<FormElementOption> GetFormElementOptionsByFormElementId(int formElementId)
        {
            return _ctx.FormElementOptions.Where(r => r.FormElementId == formElementId);
        }

        public IQueryable<ProtocolFormElementOption> GetProtocolFormElementOptions()
        {
            return _ctx.ProtocolFormElementOptions;
        }

        public IQueryable<Reply> GetRepliesByTopic(int topicId)
        {
            return _ctx.Replies.Where(r => r.TopicId == topicId);
        }

        public IQueryable<Group> GetGroups()
        {
            return _ctx.Groups;
        }

        public IQueryable<FormElement> GetFormElementsByGroup(int groupId)
        {
            return _ctx.FormElements.Where(r => r.GroupId == groupId);
        }

        //public IQueryable<ProtocolFormElementOption> GetProtocolFormElementOptionsByFormElementOptionId(int formElementOptionId) 
        //{
            //return _ctx.ProtocolFormElementOptions.Where(r => r.FormElementOption_Id == formElementOptionId);
        //}

        public IQueryable<ProtocolFormElementOption> GetProtocolFormElementOptions(int formElementOptionId)
        {
            return _ctx.ProtocolFormElementOptions.Where(r => r.FormElementOption_Id == formElementOptionId);
            //return tempId;// _ctx.Protocols.Where(r => r.Id == tempID.Protocol_Id);
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex) 
            {
                //TODO log this error
                return false;
            }
        }

        public bool AddTopic(Topic newTopic)
        {
            try
            {
                _ctx.Topics.Add(newTopic);
                return true;
            }
            catch (Exception ex)
            { 
            //TODO Log this error
                return false;
            }
        }

        public bool AddGroup(Group newGroup)
        {
            try
            {
                _ctx.Groups.Add(newGroup);
                return true;
            }
            catch (Exception ex)
            {
                //TODO log this error
                return false;
            }
        }

        public IQueryable<Topic> GetTopicsIncludingReplies()
        {
            return _ctx.Topics.Include("Replies");
        }

        public IQueryable<Group> GetGroupsIncludingFormElements()
        {
            return _ctx.Groups.Include("FormElements");
        }

        public bool AddReply(Reply newReply)
        {
              try
            {
                _ctx.Replies.Add(newReply);
                return true;
            }
            catch (Exception ex)
            { 
            //TODO Log this error
                return false;
            }
        }

        public bool AddFormElement(FormElement newFormElement)
        {
            try
            {
                _ctx.FormElements.Add(newFormElement);
                return true;
            }
            catch (Exception ex)
            { 
                //TODO log this error
                return false;
            }
        }

        public bool AddChildFormElement(ChildFormElement newChildFormElement)
        {
            try
            {
                _ctx.ChildFormElements.Add(newChildFormElement);
                return true;
            }
            catch (Exception ex)
            {
                //TODO log this error
                return false;
            }
        }

        public bool  AddProtocol(Protocol newProtocol) 
        {
            try
            {
                _ctx.Protocols.Add(newProtocol);
                return true;
            }
            catch (Exception ex)
            {
                //TODO log this error
                return false;
            }
        }
    }
    }
