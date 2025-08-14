import Modal from "react-modal";

interface CustomModalProps {
  isOpen: boolean;
  onRequestClose: () => void;
  children: React.ReactNode;
  className?: string;
}

export const CustomModal = ({ isOpen, onRequestClose, children, className }: CustomModalProps) => (
  <Modal isOpen={isOpen} onRequestClose={onRequestClose} className={className}>
    {children}
  </Modal>
);